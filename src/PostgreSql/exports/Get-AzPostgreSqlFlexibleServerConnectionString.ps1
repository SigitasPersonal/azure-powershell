
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Get the connection string according to client connection provider.
.Description
Get the connection string according to client connection provider.
.Example
PS C:\> Get-AzPostgreSqlFlexibleServerConnectionString -Client ADO.NET -ResourceGroupName PowershellPostgreSqlTest -Name postgresql-test

Server=postgresql-test.postgres.database.azure.com;Database={your_database};Port=5432;User Id=adminuser;Password={your_password};
.Example
PS C:\> Get-AzPostgreSqlFlexibleServer -ResourceGroupName PostgreSqlTestRG -ServerName PostgreSqlTestServer | Get-AzPostgreSqlFlexibleServerConnectionString -Client PHP

host=postgresqltestserver.postgres.database.azure.com port=5432 dbname={your_database} user=pwsh password={your_password} sslmode=require

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerAutoGenerated
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IServerAutoGenerated>: The server for the connection string
  Location <String>: The geo-location where the resource lives
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AdministratorLogin <String>]: The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
  [AdministratorLoginPassword <String>]: The administrator login password (required for server creation).
  [AvailabilityZone <String>]: availability Zone information of the server.
  [CreateMode <CreateMode?>]: The mode to create a new PostgreSQL server.
  [DelegatedSubnetArgumentSubnetArmResourceId <String>]: delegated subnet arm resource id.
  [DisplayName <String>]: The display name of a server.
  [HaEnabled <HaEnabledEnum?>]: stand by count value can be either enabled or disabled
  [IdentityType <ResourceIdentityType?>]: The identity type.
  [MaintenanceWindowCustomWindow <String>]: indicates whether custom window is enabled or disabled
  [MaintenanceWindowDayOfWeek <Int32?>]: day of week for maintenance window
  [MaintenanceWindowStartHour <Int32?>]: start hour for maintenance window
  [MaintenanceWindowStartMinute <Int32?>]: start minute for maintenance window
  [PointInTimeUtc <DateTime?>]: Restore point creation time (ISO8601 format), specifying the time to restore from.
  [PropertiesTag <IServerPropertiesTags>]: Application-specific metadata in the form of key-value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [SkuName <String>]: The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.
  [SkuTier <SkuTier?>]: The tier of the particular SKU, e.g. Burstable.
  [SourceServerName <String>]: The source PostgreSQL server name to restore from.
  [StorageProfileBackupRetentionDay <Int32?>]: Backup retention days for the server.
  [StorageProfileStorageMb <Int32?>]: Max storage allowed for a server.
  [Version <ServerVersion?>]: PostgreSQL Server version.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.postgresql/get-azpostgresqlflexibleserverconnectionstring
#>
function Get-AzPostgreSqlFlexibleServerConnectionString {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
    [System.String]
    # Client connection provider.
    ${Client},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ServerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
    [System.String]
    # The name of the server.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource, You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription ID that identifies an Azure subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerAutoGenerated]
    # The server for the connection string
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach.
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline.
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline.
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use.
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call.
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy.
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.PostgreSql.custom\Get-AzPostgreSqlFlexibleServerConnectionString';
            GetViaIdentity = 'Az.PostgreSql.custom\Get-AzPostgreSqlFlexibleServerConnectionString';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
