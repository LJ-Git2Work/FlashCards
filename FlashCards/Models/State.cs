using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    class State
    {
        public bool IsDirty {  get; private set; }
        public bool IsMarkedForDeletion {  get; private set; }
        public void MarkDirty() => IsDirty = true;
        public void MarkForDeletion() => IsMarkedForDeletion = true;
        public void UndoDeletion() => IsMarkedForDeletion = false;
        public void MarkSaved() {  IsDirty = false; IsMarkedForDeletion = false; }
    }
}
