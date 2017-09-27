//
//  ViewController.swift
//  FoodShare
//
//  Created by Heta Gheewala on 4/15/17.
//  Copyright © 2017 Heta Gheewala. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var userName: UITextField!
    @IBOutlet weak var password: UITextField!
    
    @IBOutlet weak var login: UIButton!
    
    @IBAction func validateLogin(_ sender: UIButton) {
        
        var loginErrorMsg:String? = ""
        
        userName.resignFirstResponder()
        password.resignFirstResponder()
        
        // Login Validations
        let emailRegEx = "[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}"
        let emailTest = NSPredicate(format:"SELF MATCHES %@", emailRegEx)
        if(!emailTest.evaluate(with: userName.text)){
            loginErrorMsg = "Please enter valid email id"
        }
        
        /*
         (?=.*[A-Z].*[A-Z])        Ensure string has two uppercase letters.
         (?=.*[!@#$&*])            Ensure string has one special case letter.
         (?=.*[0-9].*[0-9])        Ensure string has two digits.
         (?=.*[a-z].*[a-z].*[a-z]) Ensure string has three lowercase letters.
         .{8}                      Ensure string is of length 8.
         */
        
        /*
        let passwordRegEx = "^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$"
        let passwordTest = NSPredicate(format:"SELF MATCHES %@", passwordRegEx)
        loginErrorMsg = loginErrorMsg! + String(emailTest.evaluate(with: userName.text))
        
        if(!passwordTest.evaluate(with: password.text)){
            loginErrorMsg = loginErrorMsg! + "Please enter correct password. Make sure two uppercase letters,one special case letter,two digits,three lowercase letters and total lenght 8"
        }
        */
        if (loginErrorMsg != "") {
            //Login alert
            let loginError = UIAlertController(title: "Invalid Login", message: loginErrorMsg, preferredStyle: .alert)
            
            let OKAction = UIAlertAction(title: "OK", style: .default){(ACTION) in
                self.userName.text = ""
                self.password.text = ""
            }
            
            let CancelAction = UIAlertAction(title: "Cancel", style: .cancel, handler: nil)
            
            loginError.addAction(OKAction)
            loginError.addAction(CancelAction)
            
            present(loginError, animated: true, completion: nil)
        
        } else {
            
           /*
           // let goToMainView: UIStoryboardSegue?
            let source = super as! UIViewController
            let destination = super as! UIViewController
            source.present(destination, animated: true, completion: nil)
            */
        }

    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
}

