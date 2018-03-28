using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxInjecter.Utils
{
    class Inject
    {
        public static void Injectmethod( string msgboxtext, string name = null)
        {
            foreach(var type in Globals.md.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    CilBody body = method.Body;
                    body.KeepOldMaxStack = true;
                    if (!(name == null))
                    {
                        if (method.Name.Equals(name))
                        {
                           
                            InsertInstructions(MsgBox(msgboxtext), body);
                        }

                    } else
                    {
                        if(Globals.md.EntryPoint == method)
                        {
                            InsertInstructions(MsgBox(msgboxtext), body);
                        }
                    }
                }
                    
                }
            
        }
        private static void InsertInstructions(List<Instruction> instr, CilBody body)
        {
            foreach (var item in instr)
            {
                body.Instructions.Insert(1 ,item);

            }
        }
        private static List<Instruction> MsgBox(string text)
        {
            List<Instruction> instrs = new List<Instruction>();
            instrs.Add(Instruction.Create(OpCodes.Pop));

            instrs.Add(Instruction.Create(OpCodes.Call,Globals.md.Import(typeof(System.Windows.Forms.MessageBox).GetMethod("Show", new Type[] { typeof(string)}) )));
            instrs.Add(Instruction.Create(OpCodes.Ldstr, text));

            return instrs;
        }
    }
}
