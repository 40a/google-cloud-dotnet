﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.UpdateRequest;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    /// <summary>
    /// Options for <c>UpdateObject</c> operations.
    /// </summary>
    public sealed class UpdateObjectOptions
    {
        /// <summary>
        /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// Precondition for update: the object is only updated if the existing object's
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch { get; set; }

        /// <summary>
        /// Precondition for update: the object is only updated if the existing object's
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch { get; set; }

        /// <summary>
        /// Precondition for update: the object is only updated if the existing object's
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for update: the object is only updated if the existing object's
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// The projection of the updated object to return.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// A pre-defined ACL for simple access control scenarios.
        /// </summary>
        public PredefinedObjectAcl? PredefinedAcl { get; set; }

        /// <summary>
        /// If set to true, no other preconditions must be set, and
        /// the local metageneration of the object being updated is not used
        /// to create a precondition.
        /// </summary>
        public bool? ForceNoPreconditions { get; set; }

        private bool AnyExplicitPreconditions =>
            IfGenerationMatch != null || IfGenerationNotMatch != null || IfMetagenerationMatch != null || IfMetagenerationNotMatch != null;

        internal void ModifyRequest(UpdateRequest request, Object obj)
        {
            // Note the use of ArgumentException here, as this will basically be the result of invalid
            // options being passed to a public method.
            if (IfGenerationMatch != null && IfGenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfGenerationMatch)} and {nameof(IfGenerationNotMatch)} in the same options", "options");
            }
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
            }
            if (ForceNoPreconditions == true && AnyExplicitPreconditions)
            {
                throw new ArgumentException($"Cannot specify {nameof(ForceNoPreconditions)} and any explicit precondition in the same options", "options");
            }

            if (Generation != null)
            {
                request.Generation = Generation;
            }
            if (ForceNoPreconditions != true && !AnyExplicitPreconditions)
            {
                request.IfMetagenerationMatch = obj.Metageneration;
                request.IfGenerationMatch = obj.Generation;
            }
            else
            {
                if (IfGenerationMatch != null)
                {
                    request.IfGenerationMatch = IfGenerationMatch;
                }
                if (IfGenerationNotMatch != null)
                {
                    request.IfGenerationNotMatch = IfGenerationNotMatch;
                }
                if (IfMetagenerationMatch != null)
                {
                    request.IfMetagenerationMatch = IfMetagenerationMatch;
                }
                if (IfMetagenerationNotMatch != null)
                {
                    request.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
                }
            }
            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (PredefinedAcl != null)
            {
                request.PredefinedAcl =
                    GaxPreconditions.CheckEnumValue((PredefinedAclEnum) PredefinedAcl, nameof(PredefinedAcl));
            }
        }
    }
}
