﻿using System;
using System.Collections.Generic;

public partial struct Hex
{
    // 우상단부터 반시계로.
    public IEnumerable<Hex> Diagonals
    {
        get
        {
            yield return this + (1, 1);
            yield return this + (-1, 2);
            yield return this + (-2, 1);
            yield return this + (-1, -1);
            yield return this + (1, -2);
            yield return this + (2, -1);
        }
    }
    // 우측부터 시작해서 반시계 방향으로 리턴한다.
    public IEnumerable<Hex> Neighbors
    {
        get
        {
            // 우측
            yield return this + (1, 0);
            // 우상단
            yield return this + (0, 1);
            // 좌상단
            yield return this + (-1, 1);
            // 좌측
            yield return this + (-1, 0);
            // 좌하단
            yield return this + (0, -1);
            // 우하단
            yield return this + (1, -1);
        }
    }
    public IEnumerable<Hex> TrapezoidGreater => Form switch
    {
        FormEnum.FlatTopped => AsFlatTopped.TrapezoidRight,
        FormEnum.PointyTopped => AsPointyTopped.TrapezoidBottom,
        _ => throw new NotImplementedException(),
    };
    public IEnumerable<Hex> TrapezoidLess => Form switch
    {
        FormEnum.FlatTopped => AsFlatTopped.TrapezoidLeft,
        FormEnum.PointyTopped => AsPointyTopped.TrapezoidTop,
        _ => throw new NotImplementedException(),
    };
    public IEnumerable<Hex> TrianglesGreater => Form switch
    {
        FormEnum.FlatTopped => AsFlatTopped.TrianglesRight,
        FormEnum.PointyTopped => AsPointyTopped.TrianglesBottom,
        _ => throw new NotImplementedException(),
    };
    public IEnumerable<Hex> TrianglesLess => Form switch
    {
        FormEnum.FlatTopped => AsFlatTopped.TrianglesLeft,
        FormEnum.PointyTopped => AsPointyTopped.TrianglesTop,
        _ => throw new NotImplementedException(),
    };

    public static Hex Parse(string s, float length, FormEnum form)
    {
        if (string.IsNullOrWhiteSpace(s))
            return default;

        var tokens = s.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length != 2)
            throw new ArgumentException();

        return new(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]), length, form);
    }
}
