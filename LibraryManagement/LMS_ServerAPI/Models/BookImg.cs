﻿using System;
using System.Collections.Generic;

namespace LMS_ServerAPI.Models;

public partial class BookImg
{
    public int Id { get; set; }

    public int Book { get; set; }

    public byte[]? Image { get; set; }

    public virtual Book BookNavigation { get; set; } = null!;
}
