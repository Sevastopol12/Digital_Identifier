using System;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace Digital_Identifier
{

    public class DigiDen // Tree class
    {
        public DigiDen()
        {
            this.root = null;
            string file = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + @"\MOCK_DATA_transformed.csv";

            using (TextFieldParser parser = new TextFieldParser(file))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                string[] headers = parser.ReadFields();
                string[] fields;
                while ((fields = parser.ReadFields()) != null)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    string temp = fields[2].Replace("'", "").Replace("{", "").Replace("}", "").Replace(",", ":");
                    string[] holder = temp.Split(":");

                    for (int i = 0; i < holder.Length; i += 2)
                    {
                        data.Add(holder[i].Trim(), holder[i + 1].Trim());
                    }

                    this.Insert(
                        long.Parse(fields[0]),
                        fields[1],
                        fields[1],
                        data);
                }
            }
        }


        public class ID
        {
            public long key;
            public string password; 
            public Dictionary<string, string> data;
            public ID left; 
            public ID right;  

            public ID(long key, string password, Dictionary<string, string> data)
            {
                this.key = key;
                this.password = password;
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }


        private ID root;


        public void Insert(long key, string password, string password_confirmation, Dictionary<string, string> data) 
        {
            if (this.Search(key, password) is not null) 
                throw new ArgumentException("ID duplicated :<");

            if (password != password_confirmation)
                throw new ArgumentException("Passwords are not identical ._.");

            if (this.PasswordSearch(password)) 
                throw new ArgumentException("Password already used by another user :<");

            else
                this.root = this.RecursiveInsertion(this.root, key, password, data);
        }

        private ID RecursiveInsertion(ID node, long key, string password, Dictionary<string, string> data)
        {
            if (node == null)
                return new ID(key, password, data);

            if (key < node.key)
                node.left = this.RecursiveInsertion(node.left, key, password, data);
            else
                node.right = this.RecursiveInsertion(node.right, key, password, data);
            return node;
        }


        public Dictionary<string, string> Search(long key, string password)
        {
            ID result = this.RecursiveSearch(this.root, key, password);

            if (result is not null) { return result.data; }

            return null;
        }


        private ID RecursiveSearch(ID node, long key, string password)
        {
            if (node == null)
                return null;

            if (node.key == key)
            {
                if (password != node.password)
                    return null;
                else { return node; }
            }

            if (key < node.key)
                return this.RecursiveSearch(node.left, key, password);
            else
                return this.RecursiveSearch(node.right, key, password);
        }

        
        private bool PasswordSearch(string password) 
        {
            bool result = this.RecursivePasswordSearch(this.root, password);

            return result;
        }


        private bool RecursivePasswordSearch(ID node, string password)
        {
            if (node is null) return false;

            if (node.password == password) return true;

            return this.RecursivePasswordSearch(node.left, password) || this.RecursivePasswordSearch(node.right, password);
        }
    }
}
