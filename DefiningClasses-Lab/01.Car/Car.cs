﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Car
{
	private string make;
    private string model;
    private int year;

    public string Make
	{
		get { return this.make; }
		set { this.make = value; }
	}
	
	public int Year
	{
		get { return this.year; }
		set { this.year = value; }
	}
	

	public string Model
	{
		get { return this.model; }
		set { this.model = value; }
	}

}
