﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

namespace MonoGame.Tools.Pipeline
{
    public interface IController
    {
        void NewProject();

        void OpenProject(string filePath);

        void CloseProject();

        bool Exit();
    }
}
