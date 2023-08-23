﻿using AutoMapper;
using Pronia.Buisness.ViewModels.SliderViewModels;
using ProniaAppCore.Entities;

namespace Pronia.Buisness.Mappers;

public class SliderProfile:Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderPostVM>().ReverseMap();
    }
}