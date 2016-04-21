// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

namespace DataFactory.Tests.Framework.JsonSamples
{
    public class PipelineJsonSamples : JsonSampleCollection<PipelineJsonSamples>
    {

        [JsonSample(propertyBagKeys: new string[] 
            { 
                // Identify user-provided property names. These should always be cased exactly as the user specified, rather than converted to camel/Pascal-cased.
                "properties.activities[0].typeProperties.defines.PropertyBagPropertyName1"
            }
        )]
        public const string HDInsightPipeline = @"
{
    name: ""My HDInsight pipeline"",
    properties: 
    {
        description : ""HDInsight pipeline description"",
        hubName: ""MyHDIHub"",
        activities:
        [
            {
                name: ""TestActivity"",
                description: ""Test activity description"", 
                type: ""HDInsightHive"",
                typeProperties:
                {
                    script: ""SELECT 1"",
                    storageLinkedServices:
                    [
                        ""SA1"",
                        ""SA2""
                    ],
                    defines:
                    {
                        PropertyBagPropertyName1: ""PropertyBagValue1""
                    },
                    getDebugInfo : ""Failure""
                },
                linkedServiceName: ""MyLinkedServiceName""
            }
        ],
        pipelineMode: ""Scheduled"",
        expirationTime: ""5.00:00:00"",
        start: ""2001-01-01"",
        end: ""2001-01-01"",
        isPaused: false,
        runtimeInfo: 
        {
            deploymentTime: ""2002-01-01""
        }
    }
}
";


        public const string ScopeJobActivityPipeline = @"
{
  ""name"": ""0f89c1af-505b-4ddb-8608-d68266ba986a"",
  ""properties"": {
    ""activities"": [
      {
        ""type"": ""ScopeJobActivity"",
        ""typeProperties"": {
          ""isScriptLocationCosmos"": ""true"",
          ""scopeScriptFolderPath"": ""scripts"",
          ""scopeScriptFileName"": ""ScopeManagerUnitTest_Valid.script"",
          ""blobConnectionString"": ""DefaultEndpointsProtocol=https;AccountName=ssimstore;AccountKey=OybrGV4fLNZTGLCd7wS/OKHDZXNez6fhAPKoFaI+OJO54JjNz4uuFJGHJl4i0P1WYs861tNOZR7E2f42currYQ=="",
          ""blobContainerName"": ""cosmos"",
          ""priority"": """",
          ""vcPercentAllocation"": """",
          ""scopeScriptParameters"":{'runDate':'test'}
        },
        ""inputs"": [
          {
            ""name"": ""ScriptInputTable""
          }
        ],
        ""outputs"": [
          {
            ""name"": ""ScriptOutputTable""
          }
        ],
        ""policy"": {
          ""timeout"": ""00:30:00"",
          ""concurrency"": 1,
          ""executionPriorityOrder"": ""NewestFirst"",
          ""retry"": 3
        },
        ""name"": ""Scope_f38b3af0-8b49-45a3-ab42-fa10e8f2e71e"",
        ""linkedServiceName"": ""CosmosProxyLinkedService""
      }
    ],
    ""isPaused"": false,
    ""runtimeInfo"": {
      ""deploymentTime"": ""2016-03-02T19:16:00.484812Z"",
      ""activePeriodSetTime"": null,
      ""activityPeriods"": null
    },
    ""pipelineMode"": ""Scheduled""
  }
}
";
    }
}
