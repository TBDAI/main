import requests

# Define the API endpoint and your API key
endpoint = "https://api.openai.com/v1/engines/text-davinci-002/jobs"
api_key = "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"

# Define the prompt and other parameters
prompt = "Hello, how are you today?"
model = "text-davinci-002"
temperature = 0.5

# Make the API call
headers = {
    "Content-Type": "application/json",
    "Authorization": f"Bearer {api_key}"
}

data = {
    "prompt": prompt,
    "model": model,
    "temperature": temperature
}

response = requests.post(endpoint, headers=headers, json=data)

# Check the status code of the response
if response.status_code == 200:
    # Parse the response and extract the generated text
    result = response.json()
    text = result["choices"][0]["text"]
    print(text)
else:
    # Handle the error
    print("An error occurred")