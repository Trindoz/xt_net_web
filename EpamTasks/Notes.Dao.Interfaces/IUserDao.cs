using Notes.Entities;
using System;
using System.Collections.Generic;

namespace Notes.Dao.Interfaces
{
    public interface INoteDao
    {
        Note Add(Note note);
        Note GetById(int id);
        IEnumerable<Note> GetAll ();
    }
}
