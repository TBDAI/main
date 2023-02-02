import requests

response = requests.get("https://www.google.com")

print(response.status_code)
200

import json

def jprint(obj, self):
    # create a formatted string of the Python JSON object
    textt =self.textt = json.dumps(obj, sort_keys=True, indent=4)
    print(textt)

jprint(
)

