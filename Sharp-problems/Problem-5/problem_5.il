
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly problem_5
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module problem_5.exe
// MVID: {5DF75539-E9C0-43D5-B76D-DB3A101E2502}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01730000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Problems.Program
       extends [mscorlib]System.Object
{
  .field private static int32 a
  .method private hidebysig static int32 
          F() cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     int32 Problems.Program::a
    IL_0006:  ldc.i4.3
    IL_0007:  add
    IL_0008:  stsfld     int32 Problems.Program::a
    IL_000d:  ldc.i4.1
    IL_000e:  stloc.0
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.0
    IL_0012:  ret
  } // end of method Program::F

  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       29 (0x1d)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldsfld     int32 Problems.Program::a
    IL_0006:  call       int32 Problems.Program::F()
    IL_000b:  add
    IL_000c:  stsfld     int32 Problems.Program::a
    IL_0011:  ldsfld     int32 Problems.Program::a
    IL_0016:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_001b:  nop
    IL_001c:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldc.i4.0
    IL_0001:  stsfld     int32 Problems.Program::a
    IL_0006:  ret
  } // end of method Program::.cctor

} // end of class Problems.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file problems_5.res
