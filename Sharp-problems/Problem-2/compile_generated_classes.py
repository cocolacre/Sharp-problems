

import os,sys
import subprocess as sp
os.system('') #this is for enabling ASCII color codes on win7+.
#res = sp.check_output('', shell=True)

def red(text): #Works on win10, but we are not sure about other versions.
    red_text = '\033[91m'+text+' \033[39m'
    return red_text
def green(text):
    green_text = '\033[92m'+text+' \033[39m'
    return green_text

fdir = 'C:\\Users\\2\\Documents\\Sharp-problems\\Sharp-problems\\Problem-2\\Generated-classes\\'
exe_dir = 'Generated-exe'
os.chdir(exe_dir)
f = "C:\\Users\\2\\Documents\\Sharp-problems\\Sharp-problems\\Problem-2\\Generated-classes\\default.cs"
#f = "C:\Users\2\Documents\Sharp-problems\Sharp-problems\Problem-2\Generated-classes\default.cs"
for f in os.listdir(fdir):
    #f0 = "C:\\Users\\2\\Documents\\Sharp-problems\\Sharp-problems\\Problem-2\\Generated-classes\\default.cs"
    #cmd = ['C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe', '{0}'.format(f0)]
    #cmd = ['C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe', '{0}{1}'.format(fdir,f)]
    cmd = 'C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe {0}\\{1}'.format(fdir,f)
    #cmd = 'C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe {0}{1}'.format(fdir,f)
    #res = sp.check_output(cmd,shell=True)
    #res = sp.check_output(cmd)
    #res = os.system(cmd)
    #print(cmd)
    #res = sp.call(cmd)
    try:
        res = sp.check_output(cmd, shell=True)
        print(res)
        number = f.split('\\')[-1:][0].split('.')[0]
        res = sp.check_output('{0}.exe'.format(number))
        ress =str(res)[2:-1].replace('\\r\\n','')
        cmd = 'echo //{0} >> {1}{2}'.format(str(ress),fdir,f)
        os.system(cmd)
        #cmd = 'del {0}{1}'.format(fdir,f)
        #os.system(cmd)
        #cmd = 
    except Exception as _e:
        print(_e)
        print('\nERROR!\n')
    #finally:
        #break
        #
    #if str(res).__contains__('error'):
    #    print(red(error), f)
    #else:
    #    print('\nSUCCESS!\n')
    #    print(cmd)
    #    print(green(number))
        #break		