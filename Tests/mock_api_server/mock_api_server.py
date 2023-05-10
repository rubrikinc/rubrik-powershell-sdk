"""Mock API Server for running E2e tests."""
from http.server import BaseHTTPRequestHandler
from http.server import HTTPServer
import json
import logging
import os
import re

_this_dir = os.path.dirname(os.path.abspath(__file__))
DEFAULT_CACHE_FILE = _this_dir + "/mock_api_server.default_cache.json"
CURRENT_CACHE_FILE = _this_dir + "/out/mock_api_server.current_cache.json"
logging.basicConfig(level=logging.INFO)
LOG = logging.getLogger("mock_api_server")
os.makedirs(os.path.dirname(CURRENT_CACHE_FILE), exist_ok=True)


def normalize_query(query_string: str) -> str:
    query_string = query_string.replace('\t', '')
    query_string = query_string.replace('\n', '')
    query_string = query_string.replace(' ', '')
    query_string = query_string.replace('__typename', '')

    return query_string


def get_key(body):
    variables = ""
    query = ""
    if isinstance(body, str):
        body = re.sub(r"\n", "", body)
        body = json.loads(body.replace("'", '"'))
    if "query" in body:
        LOG.debug("Normalizing query: %s", body["query"])
        query = body["query"]
        query = \
            normalize_query(query[query.index('{') + 1:query.rindex('}')])
    if "variables" in body:
        variables = normalize_query(body["variables"])
    return variables + query


# a simple in-memory cache
class Cache:
    def __init__(self):
        self.cache = {}
        self.load_from_file(DEFAULT_CACHE_FILE)

    def load_from_file(self, filename):
        with open(filename, "r", encoding="utf-8") as f:
            self.update(json.load(f))
            LOG.info("Loaded cache from %s", filename)

    def save_to_file(self, filename):
        with open(filename, "w", encoding="utf-8") as f:
            json.dump(self.cache, f, sort_keys=True, indent=2)
            LOG.info("Saved cache to %s", filename)

    def update(self, new_cache: dict):
        for request in new_cache:
            if request not in self.cache:
                self.cache[request] = {}
            for body in new_cache[request]:
                response = new_cache[request][body]
                key = get_key(body)
                if key not in self.cache[request]:
                    self.cache[request][key] = {}
                self.cache[request][key].update(response)
                LOG.info(
                    "Updating cache:\n"
                    "\trequest: %s\n \tbody: %s\n \tresponse: %s",
                    request,
                    key,
                    response,
                )
        self.save_to_file(CURRENT_CACHE_FILE)

    def get(self, request, payload: dict = None):
        """Get a response from the cache.

        request is the request string, e.g. "POST /api/graphql"

        """
        if request not in self.cache:
            LOG.info(
                "Request not found: %s\nAcceptable requests are: %s",
                request,
                sorted(self.cache.keys()),
            )
            return {"error": f"request not found: {request}"}, 404

        key = get_key(payload)
        if key not in self.cache[request]:
            LOG.info("Request not found:\n%s\n%s\n", request, key)
            return {"error": f"request not found:\n\t{request}\n\t{key}\n"}, 404
        LOG.info("Getting %s %s", request, key)
        response = self.cache[request][key]
        LOG.info("Returning response: %s", response)
        return response["response"], response["status"]


CACHE = Cache()
is_api_server_alive = True


def api_server_alive():
    global is_api_server_alive
    return is_api_server_alive


def shutdown_api_server():
    global is_api_server_alive
    is_api_server_alive = False


class CacheHandler(BaseHTTPRequestHandler):
    def _send_response(self, message, status=200):
        self.send_response(status)
        self.send_header("Content-type", "application/json")
        self.end_headers()
        self.wfile.write(json.dumps(message).encode())

    def handle_request(self, method):
        global CACHE
        payload = None
        content_length = int(self.headers.get("Content-Length", 0))
        if content_length:
            payload = json.loads(self.rfile.read(content_length))
        request_key = "%s %s" % (method, self.path)
        if request_key == "POST /cache":
            CACHE.update(payload)
            self._send_response(CACHE.cache)
        elif request_key == "GET /cache":
            self._send_response(CACHE.cache)
        elif request_key == "POST /shutdown":
            shutdown_api_server()
            self._send_response({})
        else:
            self._send_response(*CACHE.get(request_key, payload))

    def do_GET(self):
        LOG.info("GET %s", self.path)
        self.handle_request("GET")

    def do_POST(self):
        LOG.info("POST %s", self.path)
        self.handle_request("POST")


def run(server_class=HTTPServer, handler_class=CacheHandler, port=8080):
    server_address = ("", port)
    httpd = server_class(server_address, handler_class)
    LOG.info("Starting mock api server on port %s...", port)
    while api_server_alive():
        httpd.handle_request()


if __name__ == "__main__":
    run()
