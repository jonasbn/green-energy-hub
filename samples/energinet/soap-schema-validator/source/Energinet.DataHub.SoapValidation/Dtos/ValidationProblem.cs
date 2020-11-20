﻿// Copyright 2020 Energinet DataHub A/S
//
// Licensed under the Apache License, Version 2.0 (the "License2");
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
using System.Xml.Schema;

namespace Energinet.DataHub.SoapValidation.Dtos
{
    public class ValidationProblem
    {
        public ValidationProblem(string message, XmlSeverityType severity, int lineNumber, int linePosition)
        {
            Message = message;
            Severity = severity;
            LineNumber = lineNumber;
            LinePosition = linePosition;
        }

        public string Message { get; }

        public XmlSeverityType Severity { get; }

        public int LineNumber { get; }

        public int LinePosition { get; }
    }
}
