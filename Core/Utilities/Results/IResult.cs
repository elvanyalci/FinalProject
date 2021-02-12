using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
   public interface IResult
    {
        bool Success { get; }//SAdece okunabilir,başarısızmı başarılımı
        string Message { get; }//true ve false sa success ise kullanıcıya mesaj
    }
}
