// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: client.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServidorEuroMilhoes {
  public static partial class EuroMilhoes
  {
    static readonly string __ServiceName = "greet.EuroMilhoes";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.Nif> __Marshaller_greet_Nif = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.Nif.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.ApostaUtilizador> __Marshaller_greet_ApostaUtilizador = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.ApostaUtilizador.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.teste> __Marshaller_greet_teste = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.teste.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.TodasApostas> __Marshaller_greet_TodasApostas = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.TodasApostas.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RegistarAposta> __Marshaller_greet_RegistarAposta = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.RegistarAposta.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RegistarApostaReply> __Marshaller_greet_RegistarApostaReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.RegistarApostaReply.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.Connection> __Marshaller_greet_Connection = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.Connection.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaArquivar> __Marshaller_greet_RespostaArquivar = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.RespostaArquivar.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.ApostasVencedoras> __Marshaller_greet_ApostasVencedoras = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.ApostasVencedoras.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaSorteio> __Marshaller_greet_RespostaSorteio = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.RespostaSorteio.Parser));
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaApostasFeitas> __Marshaller_greet_RespostaApostasFeitas = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ServidorEuroMilhoes.RespostaApostasFeitas.Parser));

    static readonly grpc::Method<global::ServidorEuroMilhoes.Nif, global::ServidorEuroMilhoes.ApostaUtilizador> __Method_ListaApostas = new grpc::Method<global::ServidorEuroMilhoes.Nif, global::ServidorEuroMilhoes.ApostaUtilizador>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostas",
        __Marshaller_greet_Nif,
        __Marshaller_greet_ApostaUtilizador);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.TodasApostas> __Method_ListaApostasAtuais = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.TodasApostas>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostasAtuais",
        __Marshaller_greet_teste,
        __Marshaller_greet_TodasApostas);

    static readonly grpc::Method<global::ServidorEuroMilhoes.RegistarAposta, global::ServidorEuroMilhoes.RegistarApostaReply> __Method_Registar = new grpc::Method<global::ServidorEuroMilhoes.RegistarAposta, global::ServidorEuroMilhoes.RegistarApostaReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Registar",
        __Marshaller_greet_RegistarAposta,
        __Marshaller_greet_RegistarApostaReply);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.Connection> __Method_TesteConeccao = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.Connection>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TesteConeccao",
        __Marshaller_greet_teste,
        __Marshaller_greet_Connection);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaArquivar> __Method_ArquivarApostas = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaArquivar>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ArquivarApostas",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaArquivar);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.ApostasVencedoras> __Method_ListaApostasVencedoras = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.ApostasVencedoras>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostasVencedoras",
        __Marshaller_greet_teste,
        __Marshaller_greet_ApostasVencedoras);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaSorteio> __Method_SetSorteioAtualFalse = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaSorteio>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetSorteioAtualFalse",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaSorteio);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaApostasFeitas> __Method_ApostasFeitas = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaApostasFeitas>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ApostasFeitas",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaApostasFeitas);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServidorEuroMilhoes.ClientReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for EuroMilhoes</summary>
    public partial class EuroMilhoesClient : grpc::ClientBase<EuroMilhoesClient>
    {
      /// <summary>Creates a new client for EuroMilhoes</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EuroMilhoesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EuroMilhoes that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EuroMilhoesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EuroMilhoesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EuroMilhoesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.ApostaUtilizador> ListaApostas(global::ServidorEuroMilhoes.Nif request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListaApostas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.ApostaUtilizador> ListaApostas(global::ServidorEuroMilhoes.Nif request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListaApostas, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.TodasApostas> ListaApostasAtuais(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListaApostasAtuais(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.TodasApostas> ListaApostasAtuais(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListaApostasAtuais, null, options, request);
      }
      public virtual global::ServidorEuroMilhoes.RegistarApostaReply Registar(global::ServidorEuroMilhoes.RegistarAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Registar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorEuroMilhoes.RegistarApostaReply Registar(global::ServidorEuroMilhoes.RegistarAposta request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Registar, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RegistarApostaReply> RegistarAsync(global::ServidorEuroMilhoes.RegistarAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegistarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RegistarApostaReply> RegistarAsync(global::ServidorEuroMilhoes.RegistarAposta request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Registar, null, options, request);
      }
      public virtual global::ServidorEuroMilhoes.Connection TesteConeccao(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TesteConeccao(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorEuroMilhoes.Connection TesteConeccao(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TesteConeccao, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.Connection> TesteConeccaoAsync(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TesteConeccaoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.Connection> TesteConeccaoAsync(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TesteConeccao, null, options, request);
      }
      public virtual global::ServidorEuroMilhoes.RespostaArquivar ArquivarApostas(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArquivarApostas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorEuroMilhoes.RespostaArquivar ArquivarApostas(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ArquivarApostas, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaArquivar> ArquivarApostasAsync(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArquivarApostasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaArquivar> ArquivarApostasAsync(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ArquivarApostas, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.ApostasVencedoras> ListaApostasVencedoras(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListaApostasVencedoras(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::ServidorEuroMilhoes.ApostasVencedoras> ListaApostasVencedoras(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListaApostasVencedoras, null, options, request);
      }
      public virtual global::ServidorEuroMilhoes.RespostaSorteio SetSorteioAtualFalse(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetSorteioAtualFalse(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorEuroMilhoes.RespostaSorteio SetSorteioAtualFalse(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetSorteioAtualFalse, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaSorteio> SetSorteioAtualFalseAsync(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetSorteioAtualFalseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaSorteio> SetSorteioAtualFalseAsync(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetSorteioAtualFalse, null, options, request);
      }
      public virtual global::ServidorEuroMilhoes.RespostaApostasFeitas ApostasFeitas(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApostasFeitas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServidorEuroMilhoes.RespostaApostasFeitas ApostasFeitas(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ApostasFeitas, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaApostasFeitas> ApostasFeitasAsync(global::ServidorEuroMilhoes.teste request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApostasFeitasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServidorEuroMilhoes.RespostaApostasFeitas> ApostasFeitasAsync(global::ServidorEuroMilhoes.teste request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ApostasFeitas, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EuroMilhoesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EuroMilhoesClient(configuration);
      }
    }

  }
}
#endregion