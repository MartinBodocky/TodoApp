using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts
{
    /// <summary>
    /// Global Ninject kernel
    /// </summary>
    public static class GlobalKernel
    {
        /// <summary>
        /// Set global kernel
        /// </summary>
        /// <param name="_kernel"></param>
        public static void SetKernel(IKernel _kernel)
        {
            _instance = _kernel;
        }

        private static IKernel _instance;
        /// <summary>
        /// Current instance
        /// </summary>
        public static IKernel Instance { get { return _instance; } }
    }
}
