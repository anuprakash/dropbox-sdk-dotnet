// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Properties of a team folder.</para>
    /// </summary>
    public class TeamFolderMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderMetadata> Encoder = new TeamFolderMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderMetadata> Decoder = new TeamFolderMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="teamFolderId">The ID of the team folder.</param>
        /// <param name="name">The name of the team folder.</param>
        /// <param name="status">The status of the team folder.</param>
        public TeamFolderMetadata(string teamFolderId,
                                  string name,
                                  TeamFolderStatus status)
        {
            if (teamFolderId == null)
            {
                throw new sys.ArgumentNullException("teamFolderId");
            }
            if (!re.Regex.IsMatch(teamFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("teamFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (status == null)
            {
                throw new sys.ArgumentNullException("status");
            }

            this.TeamFolderId = teamFolderId;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamFolderMetadata()
        {
        }

        /// <summary>
        /// <para>The ID of the team folder.</para>
        /// </summary>
        public string TeamFolderId { get; protected set; }

        /// <summary>
        /// <para>The name of the team folder.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>The status of the team folder.</para>
        /// </summary>
        public TeamFolderStatus Status { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderMetadata" />.</para>
        /// </summary>
        private class TeamFolderMetadataEncoder : enc.StructEncoder<TeamFolderMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("team_folder_id", value.TeamFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("status", value.Status, writer, Dropbox.Api.Team.TeamFolderStatus.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderMetadata" />.</para>
        /// </summary>
        private class TeamFolderMetadataDecoder : enc.StructDecoder<TeamFolderMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderMetadata Create()
            {
                return new TeamFolderMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_folder_id":
                        value.TeamFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "status":
                        value.Status = Dropbox.Api.Team.TeamFolderStatus.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
