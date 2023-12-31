// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/platforms.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PlatformService {
  public static partial class GrpcPlatform
  {
    static readonly string __ServiceName = "GrpcPlatform";

    static readonly grpc::Marshaller<global::PlatformService.GetAllRequest> __Marshaller_GetAllRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PlatformService.GetAllRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PlatformService.PlatformResponse> __Marshaller_PlatformResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PlatformService.PlatformResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::PlatformService.GetAllRequest, global::PlatformService.PlatformResponse> __Method_GetAllPlatforms = new grpc::Method<global::PlatformService.GetAllRequest, global::PlatformService.PlatformResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPlatforms",
        __Marshaller_GetAllRequest,
        __Marshaller_PlatformResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PlatformService.PlatformsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcPlatform</summary>
    [grpc::BindServiceMethod(typeof(GrpcPlatform), "BindService")]
    public abstract partial class GrpcPlatformBase
    {
      public virtual global::System.Threading.Tasks.Task<global::PlatformService.PlatformResponse> GetAllPlatforms(global::PlatformService.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcPlatformBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllPlatforms, serviceImpl.GetAllPlatforms).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcPlatformBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllPlatforms, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PlatformService.GetAllRequest, global::PlatformService.PlatformResponse>(serviceImpl.GetAllPlatforms));
    }

  }
}
#endregion
