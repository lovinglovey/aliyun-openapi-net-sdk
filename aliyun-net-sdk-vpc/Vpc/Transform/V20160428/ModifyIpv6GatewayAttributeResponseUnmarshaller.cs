/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ModifyIpv6GatewayAttributeResponseUnmarshaller
    {
        public static ModifyIpv6GatewayAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyIpv6GatewayAttributeResponse modifyIpv6GatewayAttributeResponse = new ModifyIpv6GatewayAttributeResponse();

			modifyIpv6GatewayAttributeResponse.HttpResponse = context.HttpResponse;
			modifyIpv6GatewayAttributeResponse.RequestId = context.StringValue("ModifyIpv6GatewayAttribute.RequestId");
        
			return modifyIpv6GatewayAttributeResponse;
        }
    }
}
