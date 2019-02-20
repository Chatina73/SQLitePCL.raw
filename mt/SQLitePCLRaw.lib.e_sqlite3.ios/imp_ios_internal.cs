/*
   Copyright 2014-2019 Zumero, LLC

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

[assembly: ObjCRuntime.LinkWith(
        "e_sqlite3.a",
        LinkTarget = ObjCRuntime.LinkTarget.Simulator | ObjCRuntime.LinkTarget.Simulator64 | ObjCRuntime.LinkTarget.ArmV7 | ObjCRuntime.LinkTarget.ArmV7s | ObjCRuntime.LinkTarget.Arm64,
        ForceLoad=true,
        LinkerFlags="",
        Frameworks=""
        )
        ]

