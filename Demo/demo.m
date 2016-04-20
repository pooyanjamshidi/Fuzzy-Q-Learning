% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------

%%
installQL;

clearvars -global;
% global variables declared
global ITERMAX NA NS FIS

global4 % global parameters initialized

% main data structure including the lookup table and other statistics for storing and tracking
% Q-value. Q:S*A->R, note that we can initialize the Q with any arbitrary
% value, all states are specified with [w,rt]
% vector, w=workload, rt=response time but in general this vector can have
% different structure and semantic
stat=struct('Q',zeros(NS,NA),'iter',0,'old_action',1,'old_state',[0,0],'current_state',[0,0],'rimm',0,'total_reward',0,'vector',zeros(NA,2));

%historical values
stat_h=zeros(NS,NA,ITERMAX);

done=0; % 1 stands for stopping the simulation 0 stands for continue

% index for historical Q
i=0;

while 0==done
    i=i+1;
    % observe a new state (input)
    % this function should be replaced with the input data that comes from
    % monitoring
    new_input=fuzzy_state_finder(i);
    
    [stat,done]=fuzzy_jump_learn(stat,new_input);
    
    % record temporal Q values for simulation diagrams
    stat_h(:,:,i)=stat.Q;
    
end

% updating the FLC
fis=update_fis(stat);

% show control surf (initial FIS)
gensurf(FIS);

% show control surf (updated FIS)
figure;
gensurf(fis);
