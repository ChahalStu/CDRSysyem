using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicalDocumentRepositorySystem.Data;
using ClinicalDocumentRepositorySystem.Models;

namespace ClinicalDocumentRepositorySystem.Controllers
{
    public class ClinicalRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClinicalRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClinicalRecords
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClinicalRecord.Include(c => c.Clinic).Include(c => c.Patient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClinicalRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinicalRecord = await _context.ClinicalRecord
                .Include(c => c.Clinic)
                .Include(c => c.Patient)
                .FirstOrDefaultAsync(m => m.ClinicalRecordID == id);
            if (clinicalRecord == null)
            {
                return NotFound();
            }

            return View(clinicalRecord);
        }

        // GET: ClinicalRecords/Create
        public IActionResult Create()
        {
            ViewData["ClinicID"] = new SelectList(_context.Clinic, "ClinicID", "ClinicID");
            ViewData["PatientID"] = new SelectList(_context.Set<Patient>(), "PatientID", "PatientID");
            return View();
        }

        // POST: ClinicalRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClinicalRecordID,FileName,Disorder,ClinicalContactCommenced,ClinicalContactTerminated,Date,RelevantInformation,CreatedBy,UpdatedBy,UpdatedDate,TutorEmailAddress,Clinician,AssessmentFindings,FilePath,Referral,History,ClinicID,PatientID")] ClinicalRecord clinicalRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clinicalRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClinicID"] = new SelectList(_context.Clinic, "ClinicID", "ClinicID", clinicalRecord.ClinicID);
            ViewData["PatientID"] = new SelectList(_context.Set<Patient>(), "PatientID", "PatientID", clinicalRecord.PatientID);
            return View(clinicalRecord);
        }

        // GET: ClinicalRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinicalRecord = await _context.ClinicalRecord.FindAsync(id);
            if (clinicalRecord == null)
            {
                return NotFound();
            }
            ViewData["ClinicID"] = new SelectList(_context.Clinic, "ClinicID", "ClinicID", clinicalRecord.ClinicID);
            ViewData["PatientID"] = new SelectList(_context.Set<Patient>(), "PatientID", "PatientID", clinicalRecord.PatientID);
            return View(clinicalRecord);
        }

        // POST: ClinicalRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClinicalRecordID,FileName,Disorder,ClinicalContactCommenced,ClinicalContactTerminated,Date,RelevantInformation,CreatedBy,UpdatedBy,UpdatedDate,TutorEmailAddress,Clinician,AssessmentFindings,FilePath,Referral,History,ClinicID,PatientID")] ClinicalRecord clinicalRecord)
        {
            if (id != clinicalRecord.ClinicalRecordID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clinicalRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClinicalRecordExists(clinicalRecord.ClinicalRecordID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClinicID"] = new SelectList(_context.Clinic, "ClinicID", "ClinicID", clinicalRecord.ClinicID);
            ViewData["PatientID"] = new SelectList(_context.Set<Patient>(), "PatientID", "PatientID", clinicalRecord.PatientID);
            return View(clinicalRecord);
        }

        // GET: ClinicalRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clinicalRecord = await _context.ClinicalRecord
                .Include(c => c.Clinic)
                .Include(c => c.Patient)
                .FirstOrDefaultAsync(m => m.ClinicalRecordID == id);
            if (clinicalRecord == null)
            {
                return NotFound();
            }

            return View(clinicalRecord);
        }

        // POST: ClinicalRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clinicalRecord = await _context.ClinicalRecord.FindAsync(id);
            if (clinicalRecord != null)
            {
                _context.ClinicalRecord.Remove(clinicalRecord);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClinicalRecordExists(int id)
        {
            return _context.ClinicalRecord.Any(e => e.ClinicalRecordID == id);
        }
    }
}
