﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EMS.ApplicationCore.Interfaces.Services;
using EMS.WebCore.Interfaces;
using EMS.WebCore.ViewModels.Profile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMS.ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.WebCore.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProfileViewModelService _profileViewModelService;

        public ProfileController(
            IHttpContextAccessor httpContextAccessor,
            IProfileViewModelService profileViewModelService)
        {
            _httpContextAccessor = httpContextAccessor;
            _profileViewModelService = profileViewModelService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string employeeId)
        {
            if (string.IsNullOrEmpty(employeeId))
            {
                employeeId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            }

            var viewModel = await _profileViewModelService.GetProfile(employeeId);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string employeeId)
        {
            var viewModel = await _profileViewModelService.EditProfile(employeeId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProfileEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _profileViewModelService.UpdateProfile(viewModel);
                return RedirectToAction(nameof(Index), new { employeeId = viewModel.EmployeeId });
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile(string employeeId)
        {
            var viewModel = await _profileViewModelService.EditProfile(employeeId);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditPersonalInfo(string employeeId)
        {
            var viewModel = await _profileViewModelService.GetPersonalInfo(employeeId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPersonalInfo(PersonalInfoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _profileViewModelService.UpdatePersonalInfo(viewModel);
                return RedirectToAction(nameof(Index), new { employeeId = viewModel.EmployeeId });
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployeeInfo(string employeeId)
        {
            var viewModel = await _profileViewModelService.GetEmployeeInfo(employeeId);
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEmployeeInfo(EmployeeInfoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _profileViewModelService.UpdateEmployeeInfo(viewModel);
                return RedirectToAction(nameof(Index), new { employeeId = viewModel.EmployeeId });
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditAddressInfo(string employeeId)
        {
            var viewModel = await _profileViewModelService.GetAddressInfo(employeeId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAddressInfo(AddressInfoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _profileViewModelService.UpdateAddressInfo(viewModel);
                return RedirectToAction(nameof(Index), new { employeeId = viewModel.EmployeeId });
            }

            return View(viewModel);
        }

        //[HttpGet]
        //public async Task<IActionResult> EditTransportInfo(string employeeId)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public async Task<IActionResult> EditEducationInfo(string employeeId)
        //{
        //    return View();
        //}

        public async Task<JsonResult> GetSectionByDepartmentId(int departmentId)
        {
            var items = await _profileViewModelService.GetSectionsByDepartmentId(departmentId);

            return Json(new SelectList(items, "Value", "Text"));
        }

        public async Task<JsonResult> GetJobFunctionBySectionId(int sectionId)
        {
            var items = await _profileViewModelService.GetJobFunctionBySectionId(sectionId);

            return Json(new SelectList(items, "Value", "Text"));
        }
    }
}