import codecs
files = ['Problem-2\\problem_2.cs',
        'Problem-3\\problem_3.cs',
        'Problem-4\\problem_4.cs',
        'Problem-5\\problem_5.cs']
text_list = []
text_string = []
for f in files:
    with codecs.open(f, 'r', encoding='utf-8') as input_file:
        data = input_file.readlines()
        text_list.append('\n'.join(data))
tokens_dict = {}
text_string = '\n'.join(text_list)
text_string = text_string.replace('{','')
text_string = text_string.replace('"','')
text_string = text_string.replace("'",'')
text_string = text_string.replace("//",'')
text_string = text_string.replace('}','')
text_string = text_string.replace(';','')
text_string = text_string.replace('    ',' ')
text_string = text_string.replace('   ',' ')
text_string = text_string.replace('  ',' ')
text_string = text_string.replace('  ',' ')
text_string = text_string.replace('\n',' ')
text_string = text_string.replace('\r',' ')
text_string = text_string.replace('(',' ')
text_string = text_string.replace(')',' ')
text_string = text_string.replace('.',' ')
text_string = text_string.replace(',',' ')
text_string = text_string.replace('33',' ')
text_string = text_string.replace('0',' ')
text_string = text_string.replace('1',' ')
text_string = text_string.replace('\ufeff',' ')
tokens_list = text_string.split(' ')

for token in tokens_list:
    if token in tokens_dict.keys():
        tokens_dict[token] += 1
    else:
        tokens_dict[token] = 1
tokens_list_unsorted = [(v, k) for k, v in tokens_dict.items()]
tokens_list_sorted = sorted(tokens_list_unsorted)
with open("tokens.txt", 'w') as f:
    for i,t in enumerate(tokens_list_sorted):
        print(i,t)
        f.write(str(i)+ '\t'+ str(t[1])+'\t' + str(t[0])  + '\n')