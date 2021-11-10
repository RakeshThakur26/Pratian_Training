using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEApp
{
    class Program
    {
        static void Main(string[] args)
        {

            LangJava j = new LangJava();
            LangCSharp cs = new LangCSharp();
            LangC c = new LangC();
            VBNet vb = new VBNet();
            IDE ide = new IDE();
            ide.Languages.Add(c);
            ide.Languages.Add(j);
            ide.Languages.Add(cs);
            ide.Languages.Add(vb);

            foreach (ILanguage language in ide.Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
            }

        }
    }

    class IDE
    {
        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();
    }

    public interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();

    }

    abstract class ProcLang : ILanguage
    {
        abstract public string GetName();
        public string GetUnit()
        {
            return "Functions";
        }
        public string GetParadigm()
        {
            return "Procedural";
        }



    }

    abstract class OOLanguage : ILanguage
    {
        abstract public string GetName();
       

        public string GetUnit()
        {
            return "Classes";
        }
        public string GetParadigm()
        {
            return "Object Oriented Programming";
        }
    }

    class LangJava : OOLanguage
    {
        public override string GetName()
        {
            return "Java Language";
        }
        

    }

    class LangCSharp : OOLanguage
    {
        public override string GetName()
        {
            return "CSharp Language";
        }
        

    }

    class LangC : ProcLang
    {
        public override string GetName()
        {
            return "C Language";
        }
        
    }

    class VBNet : OOLanguage
    {
        public override string GetName()
        {
            return "VB.Net";
        }

        
    }


}
