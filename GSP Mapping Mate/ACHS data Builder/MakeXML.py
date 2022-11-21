import sys


def GetTextBlock(file):

	TextBlocks=[]
	string=""
	for line in file:
		print(line)
		string+=line
		
		if line =="\n":
			TextBlocks.append(string)
			string=""
	TextBlocks.append(string)
	
	return (TextBlocks)

def BuildXML(TextBlocks):
	XMLString=""
	XMLString+="<GSPComps>\n"
	
	for block in TextBlocks:

		for CompSet in block:
			Splits = CompSet.split("\n")
			Splits = [x for x in Splits if x]
			
			XMLString+="	<Comp>\n"
			XMLString+="		<id>" + Splits[0].split()[0]+"</id>\n"
			XMLString+="		<RootComp>" + ' '.join(Splits[0].split()[1:]) +"</RootComp>\n"

			for i in range(1,len(Splits)):
				XMLString+="		<ChildComp>" + ' '.join(Splits[i].split()[1:]) +"</ChildComp>\n"
			XMLString+="	</Comp>\n"
			
			
	XMLString+="</GSPComps>\n"
	
	text_file = open("GSPComps.xml", "wt")
	n = text_file.write(XMLString)
	text_file.close()
	

TextBlocks=[]
TextBlocks.append(GetTextBlock(open("Sec1.txt")))
TextBlocks.append(GetTextBlock(open("Sec2.txt")))
TextBlocks.append(GetTextBlock(open("Sec3.txt")))
TextBlocks.append(GetTextBlock(open("Sec4.txt")))
TextBlocks.append(GetTextBlock(open("Sec5.txt")))

BuildXML(TextBlocks)