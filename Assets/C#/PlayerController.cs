using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject goal;
    public GameObject start;
    
    public AnimatorController Idle_animController;
    public AnimatorController Run_animController;

    public Avatar Idle;
    public Avatar Run;

    private Animator anim;

    public float runningSpeed;
    public bool isRunning;

    private Vector3 initPos;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(goal.transform);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        transform.position = start.transform.position + new Vector3(0, 0.5f, 0);
        initPos = transform.position;

        anim = GetComponent<Animator>();
        anim.runtimeAnimatorController = Idle_animController;
        anim.avatar = Idle;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(goal.transform);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        if (!isRunning)
        {
            transform.position = initPos;
        }
        
        if (isRunning && (!JudgeClear.clearFlag && !JudgeFailure.failureFlag))
        {
            transform.Translate(Vector3.forward * runningSpeed * Time.deltaTime);
        }
    }

    public void StartRunning()
    {
        isRunning = true;
        
        anim.runtimeAnimatorController = Run_animController;
        anim.avatar = Run;
    }

    public void Reset()
    {
        isRunning = false;
        JudgeClear.clearFlag = false;
        JudgeFailure.failureFlag = false;

        anim.runtimeAnimatorController = Idle_animController;
        anim.avatar = Idle;
        transform.position = initPos;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
