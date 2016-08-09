﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSCloudJob
    {
        
        internal Microsoft.Azure.Batch.CloudJob omObject;
        
        private IList<PSEnvironmentSetting> commonEnvironmentSettings;
        
        private PSJobConstraints constraints;
        
        private PSJobExecutionInformation executionInformation;
        
        private PSJobManagerTask jobManagerTask;
        
        private PSJobPreparationTask jobPreparationTask;
        
        private PSJobReleaseTask jobReleaseTask;
        
        private IList<PSMetadataItem> metadata;
        
        private PSPoolInformation poolInformation;
        
        private PSJobStatistics statistics;
        
        internal PSCloudJob(Microsoft.Azure.Batch.CloudJob omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public IList<PSEnvironmentSetting> CommonEnvironmentSettings
        {
            get
            {
                if (((this.commonEnvironmentSettings == null) 
                            && (this.omObject.CommonEnvironmentSettings != null)))
                {
                    List<PSEnvironmentSetting> list;
                    list = new List<PSEnvironmentSetting>();
                    IEnumerator<Microsoft.Azure.Batch.EnvironmentSetting> enumerator;
                    enumerator = this.omObject.CommonEnvironmentSettings.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSEnvironmentSetting(enumerator.Current));
                    }
                    this.commonEnvironmentSettings = list;
                }
                return this.commonEnvironmentSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.CommonEnvironmentSettings = null;
                }
                else
                {
                    this.omObject.CommonEnvironmentSettings = new List<Microsoft.Azure.Batch.EnvironmentSetting>();
                }
                this.commonEnvironmentSettings = value;
            }
        }
        
        public PSJobConstraints Constraints
        {
            get
            {
                if (((this.constraints == null) 
                            && (this.omObject.Constraints != null)))
                {
                    this.constraints = new PSJobConstraints(this.omObject.Constraints);
                }
                return this.constraints;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Constraints = null;
                }
                else
                {
                    this.omObject.Constraints = value.omObject;
                }
                this.constraints = value;
            }
        }
        
        public System.DateTime? CreationTime
        {
            get
            {
                return this.omObject.CreationTime;
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.omObject.DisplayName;
            }
            set
            {
                this.omObject.DisplayName = value;
            }
        }
        
        public string ETag
        {
            get
            {
                return this.omObject.ETag;
            }
        }
        
        public PSJobExecutionInformation ExecutionInformation
        {
            get
            {
                if (((this.executionInformation == null) 
                            && (this.omObject.ExecutionInformation != null)))
                {
                    this.executionInformation = new PSJobExecutionInformation(this.omObject.ExecutionInformation);
                }
                return this.executionInformation;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
            set
            {
                this.omObject.Id = value;
            }
        }
        
        public PSJobManagerTask JobManagerTask
        {
            get
            {
                if (((this.jobManagerTask == null) 
                            && (this.omObject.JobManagerTask != null)))
                {
                    this.jobManagerTask = new PSJobManagerTask(this.omObject.JobManagerTask);
                }
                return this.jobManagerTask;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.JobManagerTask = null;
                }
                else
                {
                    this.omObject.JobManagerTask = value.omObject;
                }
                this.jobManagerTask = value;
            }
        }
        
        public PSJobPreparationTask JobPreparationTask
        {
            get
            {
                if (((this.jobPreparationTask == null) 
                            && (this.omObject.JobPreparationTask != null)))
                {
                    this.jobPreparationTask = new PSJobPreparationTask(this.omObject.JobPreparationTask);
                }
                return this.jobPreparationTask;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.JobPreparationTask = null;
                }
                else
                {
                    this.omObject.JobPreparationTask = value.omObject;
                }
                this.jobPreparationTask = value;
            }
        }
        
        public PSJobReleaseTask JobReleaseTask
        {
            get
            {
                if (((this.jobReleaseTask == null) 
                            && (this.omObject.JobReleaseTask != null)))
                {
                    this.jobReleaseTask = new PSJobReleaseTask(this.omObject.JobReleaseTask);
                }
                return this.jobReleaseTask;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.JobReleaseTask = null;
                }
                else
                {
                    this.omObject.JobReleaseTask = value.omObject;
                }
                this.jobReleaseTask = value;
            }
        }
        
        public System.DateTime? LastModified
        {
            get
            {
                return this.omObject.LastModified;
            }
        }
        
        public IList<PSMetadataItem> Metadata
        {
            get
            {
                if (((this.metadata == null) 
                            && (this.omObject.Metadata != null)))
                {
                    List<PSMetadataItem> list;
                    list = new List<PSMetadataItem>();
                    IEnumerator<Microsoft.Azure.Batch.MetadataItem> enumerator;
                    enumerator = this.omObject.Metadata.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSMetadataItem(enumerator.Current));
                    }
                    this.metadata = list;
                }
                return this.metadata;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Metadata = null;
                }
                else
                {
                    this.omObject.Metadata = new List<Microsoft.Azure.Batch.MetadataItem>();
                }
                this.metadata = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.OnAllTasksComplete? OnAllTasksComplete
        {
            get
            {
                return this.omObject.OnAllTasksComplete;
            }
            set
            {
                this.omObject.OnAllTasksComplete = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.OnTaskFailure? OnTaskFailure
        {
            get
            {
                return this.omObject.OnTaskFailure;
            }
            set
            {
                this.omObject.OnTaskFailure = value;
            }
        }
        
        public PSPoolInformation PoolInformation
        {
            get
            {
                if (((this.poolInformation == null) 
                            && (this.omObject.PoolInformation != null)))
                {
                    this.poolInformation = new PSPoolInformation(this.omObject.PoolInformation);
                }
                return this.poolInformation;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.PoolInformation = null;
                }
                else
                {
                    this.omObject.PoolInformation = value.omObject;
                }
                this.poolInformation = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.JobState? PreviousState
        {
            get
            {
                return this.omObject.PreviousState;
            }
        }
        
        public System.DateTime? PreviousStateTransitionTime
        {
            get
            {
                return this.omObject.PreviousStateTransitionTime;
            }
        }
        
        public System.Int32? Priority
        {
            get
            {
                return this.omObject.Priority;
            }
            set
            {
                this.omObject.Priority = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.JobState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public PSJobStatistics Statistics
        {
            get
            {
                if (((this.statistics == null) 
                            && (this.omObject.Statistics != null)))
                {
                    this.statistics = new PSJobStatistics(this.omObject.Statistics);
                }
                return this.statistics;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public System.Boolean? UsesTaskDependencies
        {
            get
            {
                return this.omObject.UsesTaskDependencies;
            }
            set
            {
                this.omObject.UsesTaskDependencies = value;
            }
        }
    }
}
