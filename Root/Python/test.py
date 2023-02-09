import sys

def main():
    # Get the text from the argument, including spaces
    inputText = sys.argv[1]

    # Process the text
    result = inputText + " processed by Python script"

    # Print the result to stdout
    print(result)

if __name__ == "__main__":
    main()