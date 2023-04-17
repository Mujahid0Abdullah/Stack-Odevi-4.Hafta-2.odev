using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackOrnegi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class stack1 {
        class node
        {
           public string eleman;
            public node next;
            
        }
         node ust;
        public int len;
       public stack1()
        {
            ust = null;
            len = 0;
        }
       public void koy(string eleman)
        {
            node newItem =new node() ;
            newItem.eleman = eleman;
            newItem.next = ust;
            ust = newItem;
            len++;

        }
    
        public bool bosmu()
        {
            return ust == null;
        }
        public string al()
        {
             string deger = ust.eleman;
             ust =ust.next;
             len--;
                return deger;
        }
        public string getust()
        {
            return ust.eleman;
        }
        public void print()
        {
            int len = 0;
            node cur;
            cur = ust;
            if (cur!= null)
            {
                len++;
                cur = cur.next;
            }
            string[] s = new string[len];
            cur = ust;
            if (cur != null)
            {
                len++;
                cur = cur.next;
            }

        }
    }
    //class Stack<t>
    //{
    //    public int kapasite = 50;
    //    public t[] s;
    //    public int top;

    //    public Stack()
    //    {
    //        s = new t[kapasite];
    //        top = -1;
    //    }

    //    public bool bosmu()
    //    {
    //        return top < 0;
    //    }
    //    public bool dolumu()
    //    {
    //        if (top >= kapasite)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    public void koy(t yeni)
    //    {
    //        if (dolumu())
    //        {
    //            MessageBox.Show("stack overflow"); ;
    //        }
    //        else
    //        {
    //            top++;
    //            s[top] = yeni;

    //        }

    //    }
    //    public t ust()
    //    {
    //        if (bosmu())
    //        {
    //            Console.WriteLine("stack underflow");
    //            return default(t);
    //        }
    //        return s[top];
    //    }

    //    public t al()
    //    {

    //        if (bosmu())
    //        {


    //            Console.WriteLine("Stack underflow");
    //            return default(t);

    //        }
    //        int id = top;
    //        top--;
    //        return s[id];
    //    }
       
    //}
}
