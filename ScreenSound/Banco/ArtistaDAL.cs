using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL: DAL<Artista>
    {       

        public ArtistaDAL(ScreenSoundContext context) : base(context) { }                    
    }
}
