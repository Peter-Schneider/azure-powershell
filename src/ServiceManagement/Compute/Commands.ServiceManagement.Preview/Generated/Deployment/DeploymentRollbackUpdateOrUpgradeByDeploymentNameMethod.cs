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

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Commands.Compute.Automation.Models;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateDeploymentRollbackUpdateOrUpgradeByDeploymentNameDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pServiceName = new RuntimeDefinedParameter();
            pServiceName.Name = "ServiceName";
            pServiceName.ParameterType = typeof(System.String);
            pServiceName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pServiceName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ServiceName", pServiceName);

            var pDeploymentName = new RuntimeDefinedParameter();
            pDeploymentName.Name = "DeploymentName";
            pDeploymentName.ParameterType = typeof(System.String);
            pDeploymentName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pDeploymentName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("DeploymentName", pDeploymentName);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "DeploymentRollbackUpdateOrUpgradeByDeploymentNameParameters";
            pParameters.ParameterType = typeof(Microsoft.WindowsAzure.Management.Compute.Models.DeploymentRollbackUpdateOrUpgradeParameters);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = true
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("DeploymentRollbackUpdateOrUpgradeByDeploymentNameParameters", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteDeploymentRollbackUpdateOrUpgradeByDeploymentNameMethod(object[] invokeMethodInputParameters)
        {
            string serviceName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string deploymentName = (string)ParseParameter(invokeMethodInputParameters[1]);
            DeploymentRollbackUpdateOrUpgradeParameters parameters = (DeploymentRollbackUpdateOrUpgradeParameters)ParseParameter(invokeMethodInputParameters[2]);

            var result = DeploymentClient.RollbackUpdateOrUpgradeByDeploymentName(serviceName, deploymentName, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateDeploymentRollbackUpdateOrUpgradeByDeploymentNameParameters()
        {
            string serviceName = string.Empty;
            string deploymentName = string.Empty;
            DeploymentRollbackUpdateOrUpgradeParameters parameters = new DeploymentRollbackUpdateOrUpgradeParameters();

            return ConvertFromObjectsToArguments(new string[] { "ServiceName", "DeploymentName", "Parameters" }, new object[] { serviceName, deploymentName, parameters });
        }
    }
}
