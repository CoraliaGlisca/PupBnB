using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManager.ApplicationLogic.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public Guid EntityId { get; set; }
        public EntityNotFoundException(Guid id) : base($"Entity with id {id} was not found")
        {
        }
    }
}