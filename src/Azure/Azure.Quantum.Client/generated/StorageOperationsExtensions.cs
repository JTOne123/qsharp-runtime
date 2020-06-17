// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Quantum.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageOperations.
    /// </summary>
    public static partial class StorageOperationsExtensions
    {
            /// <summary>
            /// Gets a URL with SAS token for a container/blob in the storage account
            /// associated with the workspace. The SAS URL can be used to upload job input
            /// and/or download job output.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobDetails'>
            /// </param>
            public static SasUriResponse SasUri(this IStorageOperations operations, BlobDetails blobDetails)
            {
                return operations.SasUriAsync(blobDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a URL with SAS token for a container/blob in the storage account
            /// associated with the workspace. The SAS URL can be used to upload job input
            /// and/or download job output.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobDetails'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SasUriResponse> SasUriAsync(this IStorageOperations operations, BlobDetails blobDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SasUriWithHttpMessagesAsync(blobDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
