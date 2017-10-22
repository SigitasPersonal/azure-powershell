// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualNetworkGatewayConnectionsOperations operations.
    /// </summary>
    public partial interface IVirtualNetworkGatewayConnectionsOperations
    {
        /// <summary>
        /// The Put VirtualNetworkGatewayConnection operation creates/updates
        /// a virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The name of the virtual network gateway conenction.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Create or update Virtual Network
        /// Gateway connection operation through Network resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetworkGatewayConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put VirtualNetworkGatewayConnection operation creates/updates
        /// a virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The name of the virtual network gateway conenction.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Create or update Virtual Network
        /// Gateway connection operation through Network resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetworkGatewayConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get VirtualNetworkGatewayConnection operation retrieves
        /// information about the specified virtual network gateway
        /// connection through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The name of the virtual network gateway connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualNetworkGatewayConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Delete VirtualNetworkGatewayConnection operation deletes the
        /// specifed virtual network Gateway connection through Network
        /// resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The name of the virtual network gateway connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Delete VirtualNetworkGatewayConnection operation deletes the
        /// specifed virtual network Gateway connection through Network
        /// resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The name of the virtual network gateway connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get VirtualNetworkGatewayConnectionSharedKey operation
        /// retrieves information about the specified virtual network gateway
        /// connection shared key through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='connectionSharedKeyName'>
        /// The virtual network gateway connection shared key name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ConnectionSharedKeyResult>> GetSharedKeyWithHttpMessagesAsync(string resourceGroupName, string connectionSharedKeyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List VirtualNetworkGatewayConnections operation retrieves all
        /// the virtual network gateways connections created.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualNetworkGatewayConnection>>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets
        /// the virtual network gateway connection shared key for passed
        /// virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The virtual network gateway connection reset shared key Name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Reset Virtual Network Gateway
        /// connection shared key operation through Network resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ConnectionResetSharedKey>> ResetSharedKeyWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The VirtualNetworkGatewayConnectionResetSharedKey operation resets
        /// the virtual network gateway connection shared key for passed
        /// virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The virtual network gateway connection reset shared key Name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Reset Virtual Network Gateway
        /// connection shared key operation through Network resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ConnectionResetSharedKey>> BeginResetSharedKeyWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionResetSharedKey parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets
        /// the virtual network gateway connection shared key for passed
        /// virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The virtual network gateway connection name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Set Virtual Network Gateway
        /// conection Shared key operation throughNetwork resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ConnectionSharedKey>> SetSharedKeyWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put VirtualNetworkGatewayConnectionSharedKey operation sets
        /// the virtual network gateway connection shared key for passed
        /// virtual network gateway connection in the specified resource
        /// group through Network resource provider.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayConnectionName'>
        /// The virtual network gateway connection name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Set Virtual Network Gateway
        /// conection Shared key operation throughNetwork resource provider.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ConnectionSharedKey>> BeginSetSharedKeyWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkGatewayConnectionName, ConnectionSharedKey parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List VirtualNetworkGatewayConnections operation retrieves all
        /// the virtual network gateways connections created.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualNetworkGatewayConnection>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
