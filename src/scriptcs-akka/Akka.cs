using System;
using ScriptCs;
using ScriptCs.Contracts;

namespace ScriptCs.Akka
{
    public class Akka : ScriptPack<IScriptPackContext>
    {
        public override void Initialize (IScriptPackSession session)
        {
            session.ImportNamespace ("Akka");
            session.ImportNamespace ("Akka.Actor");
            session.ImportNamespace ("Akka.Configuration.Hocon");

            base.Initialize (session);
        }
    }

    public class AkkaContext : IScriptPackContext {
    }

        
}

