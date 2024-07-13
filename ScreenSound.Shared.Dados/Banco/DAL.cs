using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    public class DAL<T> where T : class
    {
        private readonly ScreenSoundContext context;

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }

        public void adicionar(T objeto)
        {

            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public void atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public  void deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }

        public T? RecuperarPor(Func<T, bool> condicao)
        {
           return context.Set<T>().FirstOrDefault(condicao);
        }
        public IEnumerable<T> ListarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao);
        }

    }
}
