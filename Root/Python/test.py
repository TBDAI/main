inputFile = open('inputcs.txt', 'r')
content = inputFile.read()
ans = str("The generated response is: " + content)
inputFile.close()
