using Assets.Scripts.Service;
using Assets.Scripts.Service.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class BaseContainer : MonoBehaviour
    {
        private IDataServer _server;
        private IGenerator _generator;

        public IDataServer Server => _server;
        public IGenerator Generator => _generator;
        public int CurrentPage { get; set; }

        public virtual event Action OnGenerateEnd;

        public virtual void Start()
        {

        }
        public virtual void Initialize(IDataServer server, IGenerator generator) 
        {
            _server = server;
            _generator = generator;
        }
        public virtual void FillContent(int index) { }
        public virtual int GetNextPageIndex() { return 0; }
        public virtual bool IsPageVisited(int index) { return false; }
    }
}
