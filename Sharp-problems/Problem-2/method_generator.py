import sys
method_sig_1 = []
method_sig_2 = []
method_sig_3 = []
#параметризуем токен оверрайд
method_sig_1.append("public")
method_sig_1.append("public override")

#параметризуем модификаторы аргумента тип

method_sig_2.append('')
method_sig_2.append('<T>')
#method_sig_2.append('void')
method_sig_2.append('<string>')
method_sig_2.append('<int>' )

#параметризуем аргументы
method_sig_3.append('params T[] a')
method_sig_3.append('int a'       )
method_sig_3.append('string[] a'  )
method_sig_3.append('object a'    )
all_param_N = len(method_sig_1)*len(method_sig_2)*len(method_sig_3)
print(all_param_N)

methods = []
classes = []
for i_i, i in enumerate(method_sig_1):
    for i_j, j in enumerate(method_sig_2):
        for i_k,k in enumerate(method_sig_3):
            class_declare_string = "class B{0} : A ".format((i_i+1)*(1+i_j)*(1+i_k)) + ' {'
            classes.append(class_declare_string)
            print(class_declare_string)
            method_declare_string = i + ' void F' + j + '('+k+')'
            print(method_declare_string)
            method_body = "\t{\n" + """\tConsole.WriteLine("B.F({0})");    """.format(k) + '\n\t}'
            print(method_body)
            methods.append(method_declare_string + method_body)

methods_combos = []
classes_indexes = len(classes)**2
print(classes_indexes)

for m_ind,m_1 in enumerate(methods):
    for m_2 in methods:
        if m_1 != m_2:
            #methods_combo = classes[m_ind] + '\n' +m_1+'\n' + m_2 
            methods_combo = m_1+'\n' + m_2 
            methods_combos.append(methods_combo)
with open('generated_classes.cs', 'w') as f:
    for ci, mc in enumerate(methods_combos):
        class_declare_string = "class B{0} : A ".format(ci+1) + ' {\n'
        data = class_declare_string + mc + '\n}\n'
        print(data)
        f.write(data)
for ci, mc in enumerate(methods_combos):
    data0="""
	namespace Problems
{
    using System;
    internal class Program
    {
        class A
        {
            public virtual void F(int a)
            {
                Console.WriteLine("A.F(int)");
            }
        }
		"""
    with open('Generated-classes\{0}.cs'.format(ci), 'w') as f:
        f.write(data0)
        class_declare_string = "class B{0} : A ".format(ci+1) + ' {\n'
        data = class_declare_string + mc + '\n}\n'
        f.write(data)
        data1 = """public static void Main(string[] args)""" +'\n{\n'+"new B{0}().F(33);".format(ci+1)+'\n}\n'*3
        f.write(data1)
        #break
		

sys.exit()
"""



        class B : A
        {
            public void F(object a)
            {
                Console.WriteLine("B.F(object)");
            }
            public override void F(int a)
            {
                Console.WriteLine("B.F(int)");
            }
        }


"""