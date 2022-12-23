using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.CrossCuttingConcerns.Core.Results
{
    public class EitherResult<TLeft, TRight>
    {
        private readonly TLeft? _left;
        private readonly TRight? _right;
        private readonly bool _isRight;


        public EitherResult(TRight right)
        {
            _right = right;
            _isRight = true;
            

        }

        public EitherResult(TLeft left)
        {
            _left = left;
            _isRight = false;
           
        }


         public T Result<T>(Func<TLeft,T> onLeft, Func<TRight,T> onRight) => _isRight? onRight(_right!) : onLeft(_left!);

        public bool IsRight => _isRight;

        public TRight? Right => _right;

        public TLeft? left => _left;

    }
}
