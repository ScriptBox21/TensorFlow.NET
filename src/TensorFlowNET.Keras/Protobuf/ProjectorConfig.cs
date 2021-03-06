// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/python/keras/protobuf/projector_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ThirdParty.Tensorflow.Python.Keras.Protobuf {

  /// <summary>Holder for reflection information generated from tensorflow/python/keras/protobuf/projector_config.proto</summary>
  public static partial class ProjectorConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/python/keras/protobuf/projector_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectorConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjd0ZW5zb3JmbG93L3B5dGhvbi9rZXJhcy9wcm90b2J1Zi9wcm9qZWN0b3Jf",
            "Y29uZmlnLnByb3RvEix0aGlyZF9wYXJ0eS50ZW5zb3JmbG93LnB5dGhvbi5r",
            "ZXJhcy5wcm90b2J1ZiI+Cg5TcHJpdGVNZXRhZGF0YRISCgppbWFnZV9wYXRo",
            "GAEgASgJEhgKEHNpbmdsZV9pbWFnZV9kaW0YAiADKA0izAEKDUVtYmVkZGlu",
            "Z0luZm8SEwoLdGVuc29yX25hbWUYASABKAkSFQoNbWV0YWRhdGFfcGF0aBgC",
            "IAEoCRIWCg5ib29rbWFya3NfcGF0aBgDIAEoCRIUCgx0ZW5zb3Jfc2hhcGUY",
            "BCADKA0STAoGc3ByaXRlGAUgASgLMjwudGhpcmRfcGFydHkudGVuc29yZmxv",
            "dy5weXRob24ua2VyYXMucHJvdG9idWYuU3ByaXRlTWV0YWRhdGESEwoLdGVu",
            "c29yX3BhdGgYBiABKAkinwEKD1Byb2plY3RvckNvbmZpZxIdChVtb2RlbF9j",
            "aGVja3BvaW50X3BhdGgYASABKAkSTwoKZW1iZWRkaW5ncxgCIAMoCzI7LnRo",
            "aXJkX3BhcnR5LnRlbnNvcmZsb3cucHl0aG9uLmtlcmFzLnByb3RvYnVmLkVt",
            "YmVkZGluZ0luZm8SHAoUbW9kZWxfY2hlY2twb2ludF9kaXIYAyABKAliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata), global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata.Parser, new[]{ "ImagePath", "SingleImageDim" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo), global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo.Parser, new[]{ "TensorName", "MetadataPath", "BookmarksPath", "TensorShape", "Sprite", "TensorPath" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ThirdParty.Tensorflow.Python.Keras.Protobuf.ProjectorConfig), global::ThirdParty.Tensorflow.Python.Keras.Protobuf.ProjectorConfig.Parser, new[]{ "ModelCheckpointPath", "Embeddings", "ModelCheckpointDir" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpriteMetadata : pb::IMessage<SpriteMetadata> {
    private static readonly pb::MessageParser<SpriteMetadata> _parser = new pb::MessageParser<SpriteMetadata>(() => new SpriteMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpriteMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ThirdParty.Tensorflow.Python.Keras.Protobuf.ProjectorConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpriteMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpriteMetadata(SpriteMetadata other) : this() {
      imagePath_ = other.imagePath_;
      singleImageDim_ = other.singleImageDim_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpriteMetadata Clone() {
      return new SpriteMetadata(this);
    }

    /// <summary>Field number for the "image_path" field.</summary>
    public const int ImagePathFieldNumber = 1;
    private string imagePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImagePath {
      get { return imagePath_; }
      set {
        imagePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "single_image_dim" field.</summary>
    public const int SingleImageDimFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_singleImageDim_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> singleImageDim_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// [width, height] of a single image in the sprite.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> SingleImageDim {
      get { return singleImageDim_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpriteMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpriteMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ImagePath != other.ImagePath) return false;
      if(!singleImageDim_.Equals(other.singleImageDim_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ImagePath.Length != 0) hash ^= ImagePath.GetHashCode();
      hash ^= singleImageDim_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ImagePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ImagePath);
      }
      singleImageDim_.WriteTo(output, _repeated_singleImageDim_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ImagePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImagePath);
      }
      size += singleImageDim_.CalculateSize(_repeated_singleImageDim_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpriteMetadata other) {
      if (other == null) {
        return;
      }
      if (other.ImagePath.Length != 0) {
        ImagePath = other.ImagePath;
      }
      singleImageDim_.Add(other.singleImageDim_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ImagePath = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            singleImageDim_.AddEntriesFrom(input, _repeated_singleImageDim_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmbeddingInfo : pb::IMessage<EmbeddingInfo> {
    private static readonly pb::MessageParser<EmbeddingInfo> _parser = new pb::MessageParser<EmbeddingInfo>(() => new EmbeddingInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmbeddingInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ThirdParty.Tensorflow.Python.Keras.Protobuf.ProjectorConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbeddingInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbeddingInfo(EmbeddingInfo other) : this() {
      tensorName_ = other.tensorName_;
      metadataPath_ = other.metadataPath_;
      bookmarksPath_ = other.bookmarksPath_;
      tensorShape_ = other.tensorShape_.Clone();
      sprite_ = other.sprite_ != null ? other.sprite_.Clone() : null;
      tensorPath_ = other.tensorPath_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbeddingInfo Clone() {
      return new EmbeddingInfo(this);
    }

    /// <summary>Field number for the "tensor_name" field.</summary>
    public const int TensorNameFieldNumber = 1;
    private string tensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TensorName {
      get { return tensorName_; }
      set {
        tensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata_path" field.</summary>
    public const int MetadataPathFieldNumber = 2;
    private string metadataPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MetadataPath {
      get { return metadataPath_; }
      set {
        metadataPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bookmarks_path" field.</summary>
    public const int BookmarksPathFieldNumber = 3;
    private string bookmarksPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BookmarksPath {
      get { return bookmarksPath_; }
      set {
        bookmarksPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tensor_shape" field.</summary>
    public const int TensorShapeFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_tensorShape_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> tensorShape_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// Shape of the 2D tensor [N x D]. If missing, it will be inferred from the
    /// model checkpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> TensorShape {
      get { return tensorShape_; }
    }

    /// <summary>Field number for the "sprite" field.</summary>
    public const int SpriteFieldNumber = 5;
    private global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata sprite_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata Sprite {
      get { return sprite_; }
      set {
        sprite_ = value;
      }
    }

    /// <summary>Field number for the "tensor_path" field.</summary>
    public const int TensorPathFieldNumber = 6;
    private string tensorPath_ = "";
    /// <summary>
    /// Path to the TSV file holding the tensor values. If missing, the tensor
    /// is assumed to be stored in the model checkpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TensorPath {
      get { return tensorPath_; }
      set {
        tensorPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmbeddingInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmbeddingInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TensorName != other.TensorName) return false;
      if (MetadataPath != other.MetadataPath) return false;
      if (BookmarksPath != other.BookmarksPath) return false;
      if(!tensorShape_.Equals(other.tensorShape_)) return false;
      if (!object.Equals(Sprite, other.Sprite)) return false;
      if (TensorPath != other.TensorPath) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TensorName.Length != 0) hash ^= TensorName.GetHashCode();
      if (MetadataPath.Length != 0) hash ^= MetadataPath.GetHashCode();
      if (BookmarksPath.Length != 0) hash ^= BookmarksPath.GetHashCode();
      hash ^= tensorShape_.GetHashCode();
      if (sprite_ != null) hash ^= Sprite.GetHashCode();
      if (TensorPath.Length != 0) hash ^= TensorPath.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TensorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TensorName);
      }
      if (MetadataPath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MetadataPath);
      }
      if (BookmarksPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BookmarksPath);
      }
      tensorShape_.WriteTo(output, _repeated_tensorShape_codec);
      if (sprite_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Sprite);
      }
      if (TensorPath.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TensorPath);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TensorName);
      }
      if (MetadataPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetadataPath);
      }
      if (BookmarksPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BookmarksPath);
      }
      size += tensorShape_.CalculateSize(_repeated_tensorShape_codec);
      if (sprite_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sprite);
      }
      if (TensorPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TensorPath);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmbeddingInfo other) {
      if (other == null) {
        return;
      }
      if (other.TensorName.Length != 0) {
        TensorName = other.TensorName;
      }
      if (other.MetadataPath.Length != 0) {
        MetadataPath = other.MetadataPath;
      }
      if (other.BookmarksPath.Length != 0) {
        BookmarksPath = other.BookmarksPath;
      }
      tensorShape_.Add(other.tensorShape_);
      if (other.sprite_ != null) {
        if (sprite_ == null) {
          Sprite = new global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata();
        }
        Sprite.MergeFrom(other.Sprite);
      }
      if (other.TensorPath.Length != 0) {
        TensorPath = other.TensorPath;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TensorName = input.ReadString();
            break;
          }
          case 18: {
            MetadataPath = input.ReadString();
            break;
          }
          case 26: {
            BookmarksPath = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            tensorShape_.AddEntriesFrom(input, _repeated_tensorShape_codec);
            break;
          }
          case 42: {
            if (sprite_ == null) {
              Sprite = new global::ThirdParty.Tensorflow.Python.Keras.Protobuf.SpriteMetadata();
            }
            input.ReadMessage(Sprite);
            break;
          }
          case 50: {
            TensorPath = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ProjectorConfig : pb::IMessage<ProjectorConfig> {
    private static readonly pb::MessageParser<ProjectorConfig> _parser = new pb::MessageParser<ProjectorConfig>(() => new ProjectorConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProjectorConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ThirdParty.Tensorflow.Python.Keras.Protobuf.ProjectorConfigReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectorConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectorConfig(ProjectorConfig other) : this() {
      modelCheckpointPath_ = other.modelCheckpointPath_;
      embeddings_ = other.embeddings_.Clone();
      modelCheckpointDir_ = other.modelCheckpointDir_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectorConfig Clone() {
      return new ProjectorConfig(this);
    }

    /// <summary>Field number for the "model_checkpoint_path" field.</summary>
    public const int ModelCheckpointPathFieldNumber = 1;
    private string modelCheckpointPath_ = "";
    /// <summary>
    /// Path to the checkpoint file. Use either this or model_checkpoint_dir.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModelCheckpointPath {
      get { return modelCheckpointPath_; }
      set {
        modelCheckpointPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "embeddings" field.</summary>
    public const int EmbeddingsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo> _repeated_embeddings_codec
        = pb::FieldCodec.ForMessage(18, global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo.Parser);
    private readonly pbc::RepeatedField<global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo> embeddings_ = new pbc::RepeatedField<global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ThirdParty.Tensorflow.Python.Keras.Protobuf.EmbeddingInfo> Embeddings {
      get { return embeddings_; }
    }

    /// <summary>Field number for the "model_checkpoint_dir" field.</summary>
    public const int ModelCheckpointDirFieldNumber = 3;
    private string modelCheckpointDir_ = "";
    /// <summary>
    /// Path to the checkpoint directory. The directory will be scanned for the
    /// latest checkpoint file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModelCheckpointDir {
      get { return modelCheckpointDir_; }
      set {
        modelCheckpointDir_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProjectorConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProjectorConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModelCheckpointPath != other.ModelCheckpointPath) return false;
      if(!embeddings_.Equals(other.embeddings_)) return false;
      if (ModelCheckpointDir != other.ModelCheckpointDir) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModelCheckpointPath.Length != 0) hash ^= ModelCheckpointPath.GetHashCode();
      hash ^= embeddings_.GetHashCode();
      if (ModelCheckpointDir.Length != 0) hash ^= ModelCheckpointDir.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModelCheckpointPath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ModelCheckpointPath);
      }
      embeddings_.WriteTo(output, _repeated_embeddings_codec);
      if (ModelCheckpointDir.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ModelCheckpointDir);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModelCheckpointPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModelCheckpointPath);
      }
      size += embeddings_.CalculateSize(_repeated_embeddings_codec);
      if (ModelCheckpointDir.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModelCheckpointDir);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProjectorConfig other) {
      if (other == null) {
        return;
      }
      if (other.ModelCheckpointPath.Length != 0) {
        ModelCheckpointPath = other.ModelCheckpointPath;
      }
      embeddings_.Add(other.embeddings_);
      if (other.ModelCheckpointDir.Length != 0) {
        ModelCheckpointDir = other.ModelCheckpointDir;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ModelCheckpointPath = input.ReadString();
            break;
          }
          case 18: {
            embeddings_.AddEntriesFrom(input, _repeated_embeddings_codec);
            break;
          }
          case 26: {
            ModelCheckpointDir = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
