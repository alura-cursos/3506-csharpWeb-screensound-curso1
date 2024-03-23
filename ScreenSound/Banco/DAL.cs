﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal abstract class DAL<T> where T : class
    { 
        private readonly ScreenSoundContext context;

        protected DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public  IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public abstract void Adicionar(T objeto);

        public abstract void Atualizar(T objeto);

        public abstract void Deletar(T objeto);

    }
}
