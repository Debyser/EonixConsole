using Enonix.Domain.Model.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enonix.Domain.Model
{
    public class Handler
    {
        private Monkey _monkey;

        public Handler(Monkey monkey)
        {
            _monkey = monkey;
        }
    }
}
