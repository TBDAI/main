inputFile = open('inputcs.txt', 'r')
content = inputFile.read()
ans = str("The generated response is: " + content)
inputFile.close()
 
 
outputFile = open('outputpy.txt', 'w')

fwr = outputFile.write(ans)
