//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.DataFactories.Conversion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Activity to run scope job against Cosmos VC Cluster.
    /// </summary>
    public class ScopeJobActivity : ActivityTypeProperties
    {
        /// <summary> 
        /// Identifies if the script is in Cosmos (true) or in a Blob (false).
        /// </summary> 
        [AdfRequired]
        public bool IsScriptLocationCosmos { get; set; }

        /// <summary> 
        /// Scope script folder location, either in Cosmos or in a Blob.
        /// </summary> 
        [AdfRequired]
        public string ScopeScriptFolderPath { get; set; }

        /// <summary> 
        /// Scope script file name, either in Cosmos or in a Blob.
        /// </summary> 
        [AdfRequired]
        public string ScopeScriptFileName { get; set; }

        /// <summary> 
        /// Blob connection string to access Blob storage where script file is located when IsScriptLocationCosmos is false.
        /// </summary> 
        public string BlobConnectionString { get; set; }

        /// <summary> 
        /// Blob container name when IsScriptLocationCosmos is false.
        /// </summary> 
        public string BlobContainerName { get; set; }

        /// <summary> 
        /// Cosmos Priority setting for the job.
        /// </summary> 
        [JsonConverter(typeof(ZeroIfErrorNumberConverter))]
        public int Priority { get; set; }

        /// <summary> 
        /// Cosmos TokenAllocation setting for the job.
        /// </summary> 
        [JsonConverter(typeof(ZeroIfErrorNumberConverter))]
        public int TokenAllocation { get; set; }

        /// <summary> 
        /// Cosmos VCPercentAllocation setting for the job.
        /// </summary> 
        [JsonConverter(typeof(ZeroIfErrorNumberConverter))]
        public double VcPercentAllocation { get; set; }

        /// <summary>
        /// Cosmos EmailRecipients (semicolon separated list) setting for the job.
        /// </summary> 
        public string EmailRecipients { get; set; }

        /// <summary>
        /// Cosmos ScopeScriptParameters setting for the job.
        /// </summary> 
        public IDictionary<string, string> ScopeScriptParameters { get; set; }

        public ScopeJobActivity()
        {
        }

        public ScopeJobActivity(
            bool isScriptLocationCosmos,
            string scopeScriptFolderPath,
            string scopeScriptFileName)
            : this()
        {

            this.IsScriptLocationCosmos = isScriptLocationCosmos;
            this.ScopeScriptFolderPath = scopeScriptFolderPath;
            this.ScopeScriptFileName = scopeScriptFileName;
        }
    }
}
