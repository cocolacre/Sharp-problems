
import os,sys
import subprocess as sp
fdir = 'C:\\Users\\2\\Documents\\Sharp-problems\\Sharp-problems\\Problem-2\\Generated-classes\\'
exe_dir = 'Generated-exe'
os.chdir(exe_dir)
f = "C:\\Users\\2\\Documents\\Sharp-problems\\Sharp-problems\\Problem-2\\Generated-classes\\default.cs"
for f in os.listdir(fdir):
    cmd = ['C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe', '{0}\\{1}'.format(fdir,f)]
    cmd = 'C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe {0}\\{1}'.format(fdir,f)
    cmd = 'C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe {0}\\{1}'.format(fdir,f)
    #res = sp.check_output(cmd,shell=True)
    #res = sp.check_output(cmd)
    #res = os.system(cmd)
    print(cmd)
    res = sp.call(cmd)
    print(res)
    #res = input('Continue?')
    #break