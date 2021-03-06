//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/NonformalizedDocument.proto
// Note: requires additional types generated from: Documents/ReceiptStatus.proto
namespace Diadoc.Api.Proto.Documents.NonformalizedDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NonformalizedDocumentMetadata")]
  public partial class NonformalizedDocumentMetadata : global::ProtoBuf.IExtensible
  {
    public NonformalizedDocumentMetadata() {}
    

    private Diadoc.Api.Proto.Documents.NonformalizedDocument.NonformalizedDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.NonformalizedDocument.NonformalizedDocumentStatus.UnknownNonformalizedDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.NonformalizedDocument.NonformalizedDocumentStatus.UnknownNonformalizedDocumentStatus)]
    public Diadoc.Api.Proto.Documents.NonformalizedDocument.NonformalizedDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"NonformalizedDocumentStatus")]
    public enum NonformalizedDocumentStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownNonformalizedDocumentStatus", Value=0)]
      UnknownNonformalizedDocumentStatus = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundNoRecipientSignatureRequest", Value=1)]
      OutboundNoRecipientSignatureRequest = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForRecipientSignature", Value=2)]
      OutboundWaitingForRecipientSignature = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWithRecipientSignature", Value=3)]
      OutboundWithRecipientSignature = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundRecipientSignatureRequestRejected", Value=4)]
      OutboundRecipientSignatureRequestRejected = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=13)]
      OutboundWaitingForSenderSignature = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=14)]
      OutboundInvalidSenderSignature = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundNoRecipientSignatureRequest", Value=5)]
      InboundNoRecipientSignatureRequest = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForRecipientSignature", Value=6)]
      InboundWaitingForRecipientSignature = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWithRecipientSignature", Value=7)]
      InboundWithRecipientSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundRecipientSignatureRequestRejected", Value=8)]
      InboundRecipientSignatureRequestRejected = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundInvalidRecipientSignature", Value=15)]
      InboundInvalidRecipientSignature = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalNoRecipientSignatureRequest", Value=9)]
      InternalNoRecipientSignatureRequest = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForRecipientSignature", Value=10)]
      InternalWaitingForRecipientSignature = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWithRecipientSignature", Value=11)]
      InternalWithRecipientSignature = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalRecipientSignatureRequestRejected", Value=12)]
      InternalRecipientSignatureRequestRejected = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForSenderSignature", Value=16)]
      InternalWaitingForSenderSignature = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidSenderSignature", Value=17)]
      InternalInvalidSenderSignature = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidRecipientSignature", Value=18)]
      InternalInvalidRecipientSignature = 18
    }
  
}