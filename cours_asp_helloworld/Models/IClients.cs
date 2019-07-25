using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_asp_helloworld.Models
{
    public interface IClients
    {
        List<Client> ObtenirListeClients();
    }
}
