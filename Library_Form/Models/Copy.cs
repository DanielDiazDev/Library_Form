using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Library_Form.Models
{
    public class Copy : Book
    {
        private int _editionYear;
        private string _location;

        public int EditionYear { get => _editionYear; set => _editionYear = value; }
        public string Location { get => _location; set => _location = value; }

        public Copy(string name, long isbn, string authorName, int editionYear, string location) : base(name, isbn, authorName)
        {
            this._editionYear = editionYear;
            this._location = location;
        }
    }
}
