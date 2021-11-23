using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppS6GallardoF
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
