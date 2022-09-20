﻿
using Microsoft.Extensions.DependencyInjection;
using MusicStore.DataAccess.Repositories;
using MusicStore.Services.Implementations;
using MusicStore.Services.Interfaces;

namespace MusicStore.Services;

public static class DependencyInjection
{
    /// <summary>
    /// Se agrega las dependencias de nuestras clases
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddTransient<IGenreRepository, GenreRepository>()
            .AddTransient<IGenreService, GenreService>();

        services.AddTransient<IConcertRepository, ConcertRepository>()
            .AddTransient<IConcertService, ConcertService>();

        return services;
    }
}