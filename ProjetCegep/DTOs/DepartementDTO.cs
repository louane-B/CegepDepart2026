using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCegep.DTOs
{
    public class DepartementDTO
    {
        public string No {  get; set; }

        public string Nom {  get; set; }

        public string Description { get; set; }

        public DepartementDTO(string unNo = "", string unNom = "", string uneDescription = "") 
        {
            No = unNo;
            Nom = unNom;
            Description = uneDescription;
        }

        public DepartementDTO(Departement leDepartement)
        {
            No = leDepartement.No;
            Nom = leDepartement.Nom;
            Description = leDepartement.Description;
        }
        public override string ToString()
        {
            return $"{No} - {Nom} : {Description}";
        }
    }
}
