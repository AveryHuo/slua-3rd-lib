﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using SLua;
using System;


public class lua_socket_test : MonoBehaviour
{
	LuaSvr l;


	void Start()
	{
		l = new LuaSvr("lua_socket_test");
	}

	void Update()
	{

	}
}
