using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMMS_Project.Models;

namespace EMMS_Project.Abstract
{
    public interface INormalRepository
    {
        IEnumerable<User> UserData { get; }
    }
}
